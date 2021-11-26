// Copyright © 2021 Alex Kukhtin. All rights reserved.

using System;
using System.Dynamic;
using System.Threading.Tasks;

namespace A2v10.Runtime.Interfaces;
public interface IRuntimeInvokeTarget
{
	Task<ExpandoObject> InvokeAsync(String method, ExpandoObject? parameters);
}

