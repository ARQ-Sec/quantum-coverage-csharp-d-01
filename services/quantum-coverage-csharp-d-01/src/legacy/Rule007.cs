using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule007 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0474-csharp
        // evidence_anchor: RSA.Create, RSACng, RSAOpenSsl
        // regex_sample: RSA.Create+ftXc%N;2PmA4^2VfE0,ZG4~g37t*zVm+A'|3ZJ7u'+ Xx:XTDO!&q@nAKA>H+xM?-A\Mhr%K,K\IYA[8`Mq\o%(vDui<PbEZ0lRSAOpenSsl
        // keywords: RSA.Create | RSACng | RSAOpenSsl
        RSA.Create();
    }
}
