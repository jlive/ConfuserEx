﻿using Confuser.Core;
using Confuser.Renamer.Services;
using dnlib.DotNet;

namespace Confuser.Renamer.References {
	public class MemberRefReference : INameReference<IDnlibDef> {
		readonly IDnlibDef memberDef;
		readonly MemberRef memberRef;

		public MemberRefReference(MemberRef memberRef, IDnlibDef memberDef) {
			this.memberRef = memberRef;
			this.memberDef = memberDef;
		}

		public bool UpdateNameReference(IConfuserContext context, INameService service) {
			memberRef.Name = memberDef.Name;
			return true;
		}

		public bool ShouldCancelRename() => false;
	}
}
