﻿
namespace EmbyStat.Api.EmbyClient.Cryptography
{
    public interface ICryptographyProvider
    {
        byte[] CreateSha1(byte[] value);
        byte[] CreateMD5(byte[] value);
    }
}
