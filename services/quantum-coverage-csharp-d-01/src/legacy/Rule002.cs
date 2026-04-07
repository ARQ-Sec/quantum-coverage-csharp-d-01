using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule002 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0455-csharp
        // evidence_anchor: RSA.Create, RSACng, RSACryptoServiceProvider
        // regex_sample: RSACryptoServiceProvider:{RSA.Create
        // keywords: RSA.Create | RSACng | RSACryptoServiceProvider
        RSA.Create();
    }
}
