namespace Win32
{
	/// <summary>
	/// For printer devices only, selects the size of the paper to print on.
	/// </summary>
	public enum DMPAPER : short
	{
		/// <summary>
		/// Letter 8 1/2 x 11 in
		/// </summary>
		LETTER=1,

		/// <summary>
		/// Letter Small 8 1/2 x 11 in
		/// </summary>
		LETTERSMALL=2,

		/// <summary>
		/// Tabloid 11 x 17 in
		/// </summary>
		TABLOID=3,

		/// <summary>
		/// Ledger 17 x 11 in
		/// </summary>
		LEDGER=4,

		/// <summary>
		/// Legal 8 1/2 x 14 in
		/// </summary>
		LEGAL=5,

		/// <summary>
		/// Statement 5 1/2 x 8 1/2 in
		/// </summary>
		STATEMENT=6,

		/// <summary>
		/// Executive 7 1/4 x 10 1/2 in
		/// </summary>
		EXECUTIVE=7,

		/// <summary>
		/// A3 297 x 420 mm
		/// </summary>
		A3=8,

		/// <summary>
		/// A4 210 x 297 mm
		/// </summary>
		A4=9,

		/// <summary>
		/// A4 Small 210 x 297 mm
		/// </summary>
		A4SMALL=10,

		/// <summary>
		/// A5 148 x 210 mm
		/// </summary>
		A5=11,

		/// <summary>
		/// B4 (JIS) 250 x 354
		/// </summary>
		B4=12,

		/// <summary>
		/// B5 (JIS) 182 x 257 mm
		/// </summary>
		B5=13,

		/// <summary>
		/// Folio 8 1/2 x 13 in
		/// </summary>
		FOLIO=14,

		/// <summary>
		/// Quarto 215 x 275 mm
		/// </summary>
		QUARTO=15,

		/// <summary>
		/// 10x14 in
		/// </summary>
		_10X14=16,

		/// <summary>
		/// 11x17 in
		/// </summary>
		_11X17=17,

		/// <summary>
		/// Note 8 1/2 x 11 in
		/// </summary>
		NOTE=18,

		/// <summary>
		/// Envelope #9 3 7/8 x 8 7/8
		/// </summary>
		ENV_9=19,

		/// <summary>
		/// Envelope #10 4 1/8 x 9 1/2
		/// </summary>
		ENV_10=20,

		/// <summary>
		/// Envelope #11 4 1/2 x 10 3/8
		/// </summary>
		ENV_11=21,

		/// <summary>
		/// Envelope #12 4 3/4 x 11
		/// </summary>
		ENV_12=22,

		/// <summary>
		/// Envelope #14 5 x 11 1/2
		/// </summary>
		ENV_14=23,

		/// <summary>
		/// C size sheet
		/// </summary>
		CSHEET=24,

		/// <summary>
		/// D size sheet
		/// </summary>
		DSHEET=25,

		/// <summary>
		/// E size sheet
		/// </summary>
		ESHEET=26,

		/// <summary>
		/// Envelope DL 110 x 220mm
		/// </summary>
		ENV_DL=27,

		/// <summary>
		/// Envelope C5 162 x 229 mm
		/// </summary>
		ENV_C5=28,

		/// <summary>
		/// Envelope C3  324 x 458 mm
		/// </summary>
		ENV_C3=29,

		/// <summary>
		/// Envelope C4  229 x 324 mm
		/// </summary>
		ENV_C4=30,

		/// <summary>
		/// Envelope C6  114 x 162 mm
		/// </summary>
		ENV_C6=31,

		/// <summary>
		/// Envelope C65 114 x 229 mm
		/// </summary>
		ENV_C65=32,

		/// <summary>
		/// Envelope B4  250 x 353 mm
		/// </summary>
		ENV_B4=33,

		/// <summary>
		/// Envelope B5  176 x 250 mm
		/// </summary>
		ENV_B5=34,

		/// <summary>
		/// Envelope B6  176 x 125 mm
		/// </summary>
		ENV_B6=35,

		/// <summary>
		/// Envelope 110 x 230 mm
		/// </summary>
		ENV_ITALY=36,

		/// <summary>
		/// Envelope Monarch 3.875 x 7.5 in
		/// </summary>
		ENV_MONARCH=37,

		/// <summary>
		/// 6 3/4 Envelope 3 5/8 x 6 1/2 in
		/// </summary>
		ENV_PERSONAL=38,

		/// <summary>
		/// US Std Fanfold 14 7/8 x 11 in
		/// </summary>
		FANFOLD_US=39,

		/// <summary>
		/// German Std Fanfold 8 1/2 x 12 in
		/// </summary>
		FANFOLD_STD_GERMAN=40,

		/// <summary>
		/// German Legal Fanfold 8 1/2 x 13 in
		/// </summary>
		FANFOLD_LGL_GERMAN=41,

		/// <summary>
		/// B4 (ISO) 250 x 353 mm
		/// </summary>
		ISO_B4=42,

		/// <summary>
		/// Japanese Postcard 100 x 148 mm
		/// </summary>
		JAPANESE_POSTCARD=43,

		/// <summary>
		/// 9 x 11 in
		/// </summary>
		_9X11=44,

		/// <summary>
		/// 10 x 11 in
		/// </summary>
		_10X11=45,

		/// <summary>
		/// 15 x 11 in
		/// </summary>
		_15X11=46,

		/// <summary>
		/// Envelope Invite 220 x 220 mm
		/// </summary>
		ENV_INVITE=47,

		/// <summary>
		/// RESERVED--DO NOT USE
		/// </summary>
		RESERVED_48=48,

		/// <summary>
		/// RESERVED--DO NOT USE
		/// </summary>
		RESERVED_49=49,

		/// <summary>
		/// Letter Extra 9 1/2 x 12 in
		/// </summary>
		LETTER_EXTRA=50,

		/// <summary>
		/// Legal Extra 9 1/2 x 15 in
		/// </summary>
		LEGAL_EXTRA=51,

		/// <summary>
		/// Tabloid Extra 11.69 x 18 in
		/// </summary>
		TABLOID_EXTRA=52,

		/// <summary>
		/// A4 Extra 9.27 x 12.69 in
		/// </summary>
		A4_EXTRA=53,

		/// <summary>
		/// Letter Transverse 8 1/2 x 11 in
		/// </summary>
		LETTER_TRANSVERSE=54,

		/// <summary>
		/// A4 Transverse 210 x 297 mm
		/// </summary>
		A4_TRANSVERSE=55,

		/// <summary>
		/// Letter Extra Transverse 9 1/2 x 12 in
		/// </summary>
		LETTER_EXTRA_TRANSVERSE=56,

		/// <summary>
		/// SuperA/SuperA/A4 227 x 356 mm
		/// </summary>
		A_PLUS=57,

		/// <summary>
		/// SuperB/SuperB/A3 305 x 487 mm
		/// </summary>
		B_PLUS=58,

		/// <summary>
		/// Letter Plus 8.5 x 12.69 in
		/// </summary>
		LETTER_PLUS=59,

		/// <summary>
		/// A4 Plus 210 x 330 mm
		/// </summary>
		A4_PLUS=60,

		/// <summary>
		/// A5 Transverse 148 x 210 mm
		/// </summary>
		A5_TRANSVERSE=61,

		/// <summary>
		/// B5 (JIS) Transverse 182 x 257 mm
		/// </summary>
		B5_TRANSVERSE=62,

		/// <summary>
		/// A3 Extra 322 x 445 mm
		/// </summary>
		A3_EXTRA=63,

		/// <summary>
		/// A5 Extra 174 x 235 mm
		/// </summary>
		A5_EXTRA=64,

		/// <summary>
		/// B5 (ISO) Extra 201 x 276 mm
		/// </summary>
		B5_EXTRA=65,

		/// <summary>
		/// A2 420 x 594 mm
		/// </summary>
		A2=66,

		/// <summary>
		/// A3 Transverse 297 x 420 mm
		/// </summary>
		A3_TRANSVERSE=67,

		/// <summary>
		/// A3 Extra Transverse 322 x 445 mm
		/// </summary>
		A3_EXTRA_TRANSVERSE=68,

		/// <summary>
		/// Japanese Double Postcard 200 x 148 mm
		/// </summary>
		DBL_JAPANESE_POSTCARD=69,

		/// <summary>
		/// A6 105 x 148 mm
		/// </summary>
		A6=70,

		/// <summary>
		/// Japanese Envelope Kaku #2
		/// </summary>
		JENV_KAKU2=71,

		/// <summary>
		/// Japanese Envelope Kaku #3
		/// </summary>
		JENV_KAKU3=72,

		/// <summary>
		/// Japanese Envelope Chou #3
		/// </summary>
		JENV_CHOU3=73,

		/// <summary>
		/// Japanese Envelope Chou #4
		/// </summary>
		JENV_CHOU4=74,

		/// <summary>
		/// Letter Rotated 11 x 8 1/2 11 in
		/// </summary>
		LETTER_ROTATED=75,

		/// <summary>
		/// A3 Rotated 420 x 297 mm
		/// </summary>
		A3_ROTATED=76,

		/// <summary>
		/// A4 Rotated 297 x 210 mm
		/// </summary>
		A4_ROTATED=77,

		/// <summary>
		/// A5 Rotated 210 x 148 mm
		/// </summary>
		A5_ROTATED=78,

		/// <summary>
		/// B4 (JIS) Rotated 364 x 257 mm
		/// </summary>
		B4_JIS_ROTATED=79,

		/// <summary>
		/// B5 (JIS) Rotated 257 x 182 mm
		/// </summary>
		B5_JIS_ROTATED=80,

		/// <summary>
		/// Japanese Postcard Rotated 148 x 100 mm
		/// </summary>
		JAPANESE_POSTCARD_ROTATED=81,

		/// <summary>
		/// Double Japanese Postcard Rotated 148 x 200 mm
		/// </summary>
		DBL_JAPANESE_POSTCARD_ROTATED=82,

		/// <summary>
		/// A6 Rotated 148 x 105 mm
		/// </summary>
		A6_ROTATED=83,

		/// <summary>
		/// Japanese Envelope Kaku #2 Rotated
		/// </summary>
		JENV_KAKU2_ROTATED=84,

		/// <summary>
		/// Japanese Envelope Kaku #3 Rotated
		/// </summary>
		JENV_KAKU3_ROTATED=85,

		/// <summary>
		/// Japanese Envelope Chou #3 Rotated
		/// </summary>
		JENV_CHOU3_ROTATED=86,

		/// <summary>
		/// Japanese Envelope Chou #4 Rotated
		/// </summary>
		JENV_CHOU4_ROTATED=87,

		/// <summary>
		/// B6 (JIS) 128 x 182 mm
		/// </summary>
		B6_JIS=88,

		/// <summary>
		/// B6 (JIS) Rotated 182 x 128 mm
		/// </summary>
		B6_JIS_ROTATED=89,

		/// <summary>
		/// 12 x 11 in
		/// </summary>
		_12X11=90,

		/// <summary>
		/// Japanese Envelope You #4
		/// </summary>
		JENV_YOU4=91,

		/// <summary>
		/// Japanese Envelope You #4 Rotated
		/// </summary>
		JENV_YOU4_ROTATED=92,

		/// <summary>
		/// PRC 16K 146 x 215 mm
		/// </summary>
		P16K=93,

		/// <summary>
		/// PRC 32K 97 x 151 mm
		/// </summary>
		P32K=94,

		/// <summary>
		/// PRC 32K(Big) 97 x 151 mm
		/// </summary>
		P32KBIG=95,

		/// <summary>
		/// PRC Envelope #1 102 x 165 mm
		/// </summary>
		PENV_1=96,

		/// <summary>
		/// PRC Envelope #2 102 x 176 mm
		/// </summary>
		PENV_2=97,

		/// <summary>
		/// PRC Envelope #3 125 x 176 mm
		/// </summary>
		PENV_3=98,

		/// <summary>
		/// PRC Envelope #4 110 x 208 mm
		/// </summary>
		PENV_4=99,

		/// <summary>
		/// PRC Envelope #5 110 x 220 mm
		/// </summary>
		PENV_5=100,

		/// <summary>
		/// PRC Envelope #6 120 x 230 mm
		/// </summary>
		PENV_6=101,

		/// <summary>
		/// PRC Envelope #7 160 x 230 mm
		/// </summary>
		PENV_7=102,

		/// <summary>
		/// PRC Envelope #8 120 x 309 mm
		/// </summary>
		PENV_8=103,

		/// <summary>
		/// PRC Envelope #9 229 x 324 mm
		/// </summary>
		PENV_9=104,

		/// <summary>
		/// PRC Envelope #10 324 x 458 mm
		/// </summary>
		PENV_10=105,

		/// <summary>
		/// PRC 16K Rotated
		/// </summary>
		P16K_ROTATED=106,

		/// <summary>
		/// PRC 32K Rotated
		/// </summary>
		P32K_ROTATED=107,

		/// <summary>
		/// PRC 32K(Big) Rotated
		/// </summary>
		P32KBIG_ROTATED=108,

		/// <summary>
		/// PRC Envelope #1 Rotated 165 x 102 mm
		/// </summary>
		PENV_1_ROTATED=109,

		/// <summary>
		/// PRC Envelope #2 Rotated 176 x 102 mm
		/// </summary>
		PENV_2_ROTATED=110,

		/// <summary>
		/// PRC Envelope #3 Rotated 176 x 125 mm
		/// </summary>
		PENV_3_ROTATED=111,

		/// <summary>
		/// PRC Envelope #4 Rotated 208 x 110 mm
		/// </summary>
		PENV_4_ROTATED=112,

		/// <summary>
		/// PRC Envelope #5 Rotated 220 x 110 mm
		/// </summary>
		PENV_5_ROTATED=113,

		/// <summary>
		/// PRC Envelope #6 Rotated 230 x 120 mm
		/// </summary>
		PENV_6_ROTATED=114,

		/// <summary>
		/// PRC Envelope #7 Rotated 230 x 160 mm
		/// </summary>
		PENV_7_ROTATED=115,

		/// <summary>
		/// PRC Envelope #8 Rotated 309 x 120 mm
		/// </summary>
		PENV_8_ROTATED=116,

		/// <summary>
		/// PRC Envelope #9 Rotated 324 x 229 mm
		/// </summary>
		PENV_9_ROTATED=117,

		/// <summary>
		/// PRC Envelope #10 Rotated 458 x 324 mm
		/// </summary>
		PENV_10_ROTATED=118,

		/// <summary>
		/// First predefined paper size.
		/// </summary>
		FIRST=LETTER,

		/// <summary>
		/// Last predefined paper size.
		/// </summary>
		LAST=PENV_10_ROTATED,

		/// <summary>
		/// Start of the user-defined paper sizes.
		/// </summary>
		USER=256,
	}
}
