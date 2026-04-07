using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule005 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0471-csharp
        // evidence_anchor: AesGcm
        // regex_sample: AesGcm
        // keywords: AesGcm
        new AesGcm(new byte[16]);
    }
}
