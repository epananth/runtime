// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.Security.Cryptography.Cng.Tests
{
    public class ECDsaCngPkcs8Tests : CngPkcs8Tests<ECDsaCng>
    {
        protected override ECDsaCng CreateKey(out CngKey cngKey)
        {
            ECDsaCng key = new ECDsaCng(ECCurve.NamedCurves.nistP521);
            cngKey = key.Key;
            return key;
        }

        protected override void VerifyMatch(ECDsaCng exported, ECDsaCng imported)
        {
            byte[] data = { 8, 4, 1, 2, 11 };
            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA256;

            byte[] signature = imported.SignData(data, hashAlgorithm);
            Assert.True(exported.VerifyData(data, signature, hashAlgorithm));
        }
    }
}
