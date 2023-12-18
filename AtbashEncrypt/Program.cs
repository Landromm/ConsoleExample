
Console.WriteLine("Атбаш шифрование.");
var atbash = new Atbash();

Console.Write("Введите текст сообщения: ");
var message = Console.ReadLine();
var encryptedMessage = atbash.EncryptText(message!);

Console.WriteLine("Зашифрованное сообщение: {0}", encryptedMessage);
var decryptedMessage = atbash.DecryptText(encryptedMessage);

Console.WriteLine("Расшифрованное сообщение: {0}", decryptedMessage);
Console.ReadLine();
