using System;
using System.Security.Cryptography;
namespace Arq.Lab.Coverage;
public static class Rule018 {
    public static void Execute() {
        // rule_key: quantum.arq-q-0495-csharp
        // evidence_anchor: ECDsa.Create
        // regex_sample: ECDsa.Createu eZz ku!=Ce{:AHeN6EqiIw%"bI5Jzc*md4*FqePyl}~4D.E;OiXz],al|K|eJx{i-u8+axPl{r}H1tY5o,J!u/l[K(6ECDsaOpenSsl
        // keywords: ECDsa.Create | ECDsaCng | ECDsaOpenSsl
        ECDsa.Create();
    }
}
