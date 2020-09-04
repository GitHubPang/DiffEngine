﻿using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;

[UsesVerify]
public class HotKeyControlTests :
    XunitContextBase
{
    public HotKeyControlTests(ITestOutputHelper output) :
        base(output)
    {
    }

#if DEBUG
    [Fact]
    public async Task WithKeys()
    {
        using var target = new HotKeyControl()
        {
            IsShift = true,
            Key = "A",
            KeyEnabled = true
        };
        await Verifier.Verify(target);
    }

    [Fact]
    public async Task Default()
    {
        using var target = new HotKeyControl();
        await Verifier.Verify(target);
    }
#endif
}