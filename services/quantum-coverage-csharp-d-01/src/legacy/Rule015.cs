using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule015 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0492-csharp
        // evidence_anchor: ChaCha20Poly1305
        // regex_sample: ChaCha20Poly1305
        // keywords: ChaCha20Poly1305
        new ChaCha20Poly1305(new byte[32]);
    }
}
