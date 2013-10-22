﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.Shared.Network;
using Aura.Login.Network.Handlers;

namespace Aura.Login.Network
{
	public class LoginServer : MabiDefaultServer<LoginClient>
	{
		public static readonly LoginServer Instance = new LoginServer();

		private LoginServer()
			: base()
		{
			this.Handlers = new LoginServerHandlers();
			this.Handlers.AutoLoad();
		}
	}
}