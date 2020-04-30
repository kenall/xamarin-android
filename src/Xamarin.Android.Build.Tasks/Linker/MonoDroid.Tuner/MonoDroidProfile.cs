using System;
using System.Collections.Generic;

#if !NET5_LINKER
using Mono.Tuner;
#endif
using Mobile.Tuner;

using Mono.Cecil;

namespace MonoDroid.Tuner {

	class MonoDroidProfile : MobileProfile {

		protected override bool IsProduct (string assemblyName)
		{
			return assemblyName == "Mono.Android";
		}

		protected override bool IsSdk (string assemblyName)
		{
			return assemblyName.Equals ("Java.Interop", StringComparison.Ordinal)
			       || assemblyName.Equals ("Java.Interop.GenericMarshaler", StringComparison.Ordinal)
			       || base.IsSdk (assemblyName);
		}
	}
}
