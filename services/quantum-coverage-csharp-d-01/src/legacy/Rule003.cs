using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule003 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0457-csharp
        // evidence_anchor: ECDsa.Create, ECDsaCng
        // regex_sample: ECDsa.CreateV$!Z$F0}qD5nqda&b^ZqOE0$p*F]o$\0iD 7]- q|B0yn2*/=p) fECDsaCng
        // keywords: ECDsa.Create | ECDsaCng
        ECDsa.Create();
    }
}
