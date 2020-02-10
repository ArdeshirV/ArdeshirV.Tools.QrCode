/* 
 * QR code generator library (.NET)
 *
 * Copyright (c) ArdeshirV@protonmail.com (MIT License)
 * https://ardeshirv.github.io/ArdeshirV.Utility.QrCode/
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
 * IN THE SOFTWARE.
 */
using System;
using System.Drawing;
using QrCode.Properties;

namespace ArdeshirV.Utilities.QrCode
{
	/// <summary>
	/// Access to local resources
	/// </summary>
	public static class Res
	{
		public static Image NayukiAvator {
			get {
				return Resources.Nayuki;
			}
		}
		
		public static Image ManuelBleichenbacherAvator {
			get {
				return Resources.ManuelBleichenbacher;
			}
		}
		
		public static string License {
			get {
				return Resources.LICENSE;
			}
		}
		
		public static Image Logo {
			get {
				return Resources.Logo;
			}
		}
		
		public static Image LicenseLogo {
			get {
				return Resources.MIT;
			}
		}
	}
}
