using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule014 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0491-csharp
        // evidence_anchor: AesGcm
        // regex_sample: AesGcm
        // keywords: AesGcm
        new AesGcm(new byte[16]);
    }
}
