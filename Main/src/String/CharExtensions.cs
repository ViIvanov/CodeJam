﻿using JetBrains.Annotations;

namespace CodeJam
{
	/// <summary>
	/// <see cref="char"/> structure extensions.
	/// </summary>
	[PublicAPI]
	public static class CharExtensions
	{
		/// <summary>
		/// Infix form of <see cref="char.IsLetter(char)"/>.
		/// </summary>
		public static bool IsLetter(this char chr) => char.IsLetter(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsDigit(char)"/>.
		/// </summary>
		public static bool IsDigit(this char chr) => char.IsDigit(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsLetterOrDigit(char)"/>.
		/// </summary>
		public static bool IsLetterDigit(this char chr) => char.IsLetterOrDigit(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsWhiteSpace(char)"/>.
		/// </summary>
		public static bool IsWhiteSpace(this char chr) => char.IsWhiteSpace(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsControl(char)"/>.
		/// </summary>
		public static bool IsControl(this char chr) => char.IsControl(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsSurrogate(char)"/>.
		/// </summary>
		public static bool IsSurrogate(this char chr) => char.IsSurrogate(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsHighSurrogate(char)"/>.
		/// </summary>
		public static bool IsHightSurrogate(this char chr) => char.IsHighSurrogate(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsLowSurrogate(char)"/>.
		/// </summary>
		public static bool IsLowSurrogate(this char chr) => char.IsLowSurrogate(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsLower(char)"/>.
		/// </summary>
		public static bool IsLower(this char chr) => char.IsLower(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsUpper(char)"/>.
		/// </summary>
		public static bool IsUpper(this char chr) => char.IsUpper(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsNumber(char)"/>.
		/// </summary>
		public static bool IsNumber(this char chr) => char.IsNumber(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsPunctuation(char)"/>.
		/// </summary>
		public static bool IsPunctuation(this char chr) => char.IsPunctuation(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsSeparator(char)"/>.
		/// </summary>
		public static bool IsSeparator(this char chr) => char.IsSeparator(chr);

		/// <summary>
		/// Infix form of <see cref="char.IsSymbol(char)"/>.
		/// </summary>
		public static bool IsSymbol(this char chr) => char.IsSymbol(chr);
	}
}