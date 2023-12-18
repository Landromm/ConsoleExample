using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Атбаш шифрование.
public class Atbash
{
	//Алфавит языка:
	private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

	//Метод для переворачивания строки:
	private string Reverse(string inputText)
	{
		var reversedText = string.Empty;	//Переменная для хранения результата:
		foreach (var s in inputText)
			reversedText = s + reversedText;//Добавляем символ в начало строки:

		return reversedText;
	}

	//Метод шифрования/дешифрования:
	private string EncryptDecrypt(string text, string symbols, string cipher)
	{
		//Переводим текст в нижний регистр:
		text = text.ToLower();

		var outputText = string.Empty;
		for (var i = 0; i < text.Length; i++)
		{
			//Поиск позиции символа в строке алфавита:
			var index = symbols.IndexOf(text[i]);
			if (index >= 0)
				//Замена символа на шифр:
				outputText += cipher[index].ToString();
		}
		return outputText;
	}

	//Шифрование текста:
	public string EncryptText(string plainText)
	{
		return EncryptDecrypt(plainText, alphabet, Reverse(alphabet));
	}

	//Расшифровка текста:
	public string DecryptText(string encryptedText)
	{
		return EncryptDecrypt(encryptedText, Reverse(alphabet), alphabet);
	}
}