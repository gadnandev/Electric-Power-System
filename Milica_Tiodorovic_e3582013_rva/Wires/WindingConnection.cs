///////////////////////////////////////////////////////////
//  WindingConnection.cs
//  Implementation of the Enumeration WindingConnection
//  Generated by Enterprise Architect
//  Created on:      21-Sep-2016 12:15:15 PM
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace CIM.IEC61970.Base.Wires {
	/// <summary>
	/// Winding connection type.
	/// </summary>
	public enum WindingConnection : int {

		/// <summary>
		/// Delta
		/// </summary>
		D,
		/// <summary>
		/// Wye
		/// </summary>
		Y,
		/// <summary>
		/// ZigZag
		/// </summary>
		Z,
		/// <summary>
		/// Wye, with neutral brought out for grounding.
		/// </summary>
		Yn,
		/// <summary>
		/// ZigZag, with neutral brought out for grounding.
		/// </summary>
		Zn,
		/// <summary>
		/// Autotransformer common winding
		/// </summary>
		A,
		/// <summary>
		/// Independent winding, for single-phase connections
		/// </summary>
		I

	}//end WindingConnection

}//end namespace Wires