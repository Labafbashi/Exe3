﻿using System;

class TextInputError : UserError
{
	public TextInputError()
	{
	}

	public override string UEMessage()
	{
		return "You tried to use a text\r\ninput in a numeric only field. This fired an error!";

    }
}