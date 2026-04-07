using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule008 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0476-csharp
        // evidence_anchor: ECDsa.Create, ECDsaCng, ECDsaOpenSsl
        // regex_sample: ECDsa.Create7i7eJ(JP_Ie?^8tq@% y2HW,XWK5g0#aPYJ)CYf`HX"$>5-idkmQ@Cw<A/c_M1Ew%sE^v3_jByJ?k+dAi5Eq\"K0ECDsaOpenSsl
        // keywords: ECDsa.Create | ECDsaCng | ECDsaOpenSsl
        ECDsa.Create();
    }
}
