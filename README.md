# DEMO of using [RSACryptoServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.rsacryptoserviceprovider?view=netframework-4.7.2) with [JSEncrypt lib](https://github.com/travist/jsencrypt)
## [Client side Demo](https://worlaf.github.io/RSADemo/JS%20Demo/index.html)
## Brief review
RSACryptoServiceProvider uses "raw" keys representation (see [docs](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.rsaparameters?view=netframework-4.7.2)).

JSEncrypt uses "PEM" keys format (see [ASN.1 key structures in DER and PEM](https://tls.mbed.org/kb/cryptography/asn1-key-structures-in-der-and-pem), [RSA key breakdown](https://etherhack.co.uk/asymmetric/docs/rsa_key_breakdown.html)).
 
So, workflow could be following:

Generate keys by creation of new instance of RSACryptoServiceProvider with preferred key size.

Create PEM-formatted string to use with JSEncrypt (see [`RSAUtil.ExportPublicKeyToPemString`](https://github.com/Worlaf/RSADemo/blob/master/RSADemo_WinForms/RSAUtil.cs#L21), code from [here](https://stackoverflow.com/questions/28406888/c-sharp-rsa-public-key-output-not-correct/28407693#28407693)).

Code sample:

```
rsaProvider = new RSACryptoServiceProvider(keySize);
var pemFormattedKey = RsaUtil.ExportPublicKeyToPemString(rsaProvider); // key to use with JSEncrypt
```

Keys can be exported and imported from XML string (`RSACryptoServiceProvider.FromXmlString` and `RSACryptoServiceProvider.ToXmlString`).

_CspParameters_ can be used as more secure way to store keys (as microsoft says, [docs](https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.cspparameters?view=netframework-4.7.2)).

Code sample:

```
var cspParams = new CspParameters
{
    KeyContainerName = storageName,
    Flags = CspProviderFlags.UseMachineKeyStore
};
var rsaProvider = new RSACryptoServiceProvider(keySize, cspParams);
```
RSA key will be generated and stored in container with specified name if container is not exists. Otherwise, RSA key will be loaded from container (keySize will be ignored). Containers are stored in file system (I found them here `C:\ProgramData\Microsoft\Crypto\RSA\MachineKeys`).

Use _pemFormattedKey_ to encrypt text on client side:
```
var encrypt = new JSEncrypt(); 
encrypt.setKey(pemFormattedKey); // use PEM-formatted key
var encryptedBase64String = encrypt.encrypt(textToEncrypt);
```

Now we have array of bytes in base64 format.

Sample code for decryption:
```
var encryptedBytes = Convert.FromBase64String(encryptedBase64String);
var decryptedBytes = rsaProvider.Decrypt(encryptedBytes, false); 
var decryptedString = Encoding.UTF8.GetString(decryptedBytes);
```
