// Copyright (C) 2021 jmh
// SPDX-License-Identifier: GPL-3.0-only

using System.Collections.Generic;

namespace AuthenticatorPro.Shared.View
{
    public interface IView<out T> : IReadOnlyList<T>
    {
        public void Update();
    }
}