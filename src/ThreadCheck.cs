#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2021 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

using System;
using System.Threading;

namespace Microsoft.Xna.Framework
{
	public static class ThreadCheck
	{
		private static int mainThreadId = -1;

		public static bool IsMainThread => Environment.CurrentManagedThreadId == mainThreadId;

		public static void CheckThread()
		{
			if (mainThreadId < 0)
				mainThreadId = Environment.CurrentManagedThreadId;
			else if(!IsMainThread)
				throw new ThreadStateException("most FNA3D audio/graphics functions must be called on the main thread");
		}
	}
}
