
	//Метод обмена элементов:
	static void Swap(ref int e1, ref int e2)
	{
		var temp = e1;
		e1 = e2;
		e2 = temp;
	}
	//Сортировка перемешиванием:
	static int[] ShakerSort(int[] array)
	{
		for (var i = 0; i < array.Length / 2; i++)
		{
			var swapFlag = false;
			//Проход слева направо:
			for (var j = i; j < array.Length - i - 1; j++)
			{
				if (array[j] > array[j + 1])
				{
					Swap(ref array[j], ref array[j + 1]);
					swapFlag = true;
				}
			}
			//Проход справа налево:
			for (var j = array.Length - 2 - i; j > i; j--)
			{
				if (array[j - 1] > array[j])
				{
					Swap(ref array[j - 1], ref array[j]);
					swapFlag = true;
				}
			}
			//Если обменов не было - выходим.
			if (!swapFlag)
				break;
		}

		return array;
	}

	Console.WriteLine("Шейкерная сортировка");
	Console.Write("Введите элементы массива: ");

	var parts = Console.ReadLine()!
		.Split(
			new[] { " ", ",", ";" }, 
			StringSplitOptions.RemoveEmptyEntries);

	var array = new int[parts.Length];
	for (int i = 0; i < parts.Length; i++)
		array[i] = Convert.ToInt32(parts[i]);

	Console.WriteLine(
		"Отсортированный массив: {0}", 
		string.Join(
			", ", 
			ShakerSort(array)));

	Console.ReadLine();
	
