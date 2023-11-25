Исходя из набора тестов, создать класс, моделирующий работу коллекции типа "Массив".
Массив имеет заданную при создании экземпляра ёмкость, позволяет заполнять себя псевдослучайными числами
и имеет оператор взятия индекса:

public class Indexed
{
	private string _data;

	public string this[int index]
	{
		get => _array[index];
		set => _array[index] = value;
	}

	public Indexed(int capacity) => _data = new string[capacity];
}

