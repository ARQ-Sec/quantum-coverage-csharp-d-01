using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule017 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0494-csharp
        // evidence_anchor: RSA.Create
        // regex_sample: RSA.CreateoJNEwz-uW1$ymb#IC]),K i_Uq|-<>=`*r_ zCf-7TbDv!J1r)7s <z0hm`\HhE~:O3RSAOpenSsl
        // keywords: RSA.Create | RSACng | RSAOpenSsl
        RSA.Create();
    }
}
