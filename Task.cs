class Task{
	    public static string[] stringArrayLessThan4Char (string[] array){

        int newArraySize = 0;

        for(int i = 0; i < array.Length; i++) {
			if(array[i].Length <= 3) {
				newArraySize++;
			}
		}

        string[] result = new string[newArraySize];

		for(int i = 0, j = 0; i < array.Length; i++) {
			if(array[i].Length <= 3) {
				result[j] = array[i];
				j++;
			}
		}

        return result;
    }
    public static void Main(string[] args){

        string[] array = {"asd", "fdsa", "fdsff", "qw"};
        string[] newArray = stringArrayLessThan4Char(array);

    }
}
