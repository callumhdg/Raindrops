# Raindrops

## Objectives

1. If the input number has a factor of 3, output 'Pling'.
2. If the input number has a factor of 5, output 'Plang'.
3. If the input number has a factor of 7, output 'Plong'.
4. If the input number does not have any of the above as a factor simply return the numbers digits.
5. If is a factor of more than one of the three conditions then return both outputs.



## Function

```c#
public string PlingPlangPlong(int input)
{
	StringBuilder sb = new StringBuilder();

	if (input % 3 == 0){
		sb.Append("Pling");
	}

	if (input % 5 == 0){
		sb.Append("Plang");
	}

	if (input % 7 == 0){
		sb.Append("Plong");
	}

	return (sb.Length != 0) ? sb.ToString() : input.ToString();
}
```

This method checks if an input integer is divisible by 3, 5 or 7. If any conditions are met the corresponding string is returned, in contrast if the input is not divisible by 3, 5 or 7 then the input number is returned.



I chose to use a ```StringBuilder``` instead of a ```string``` because it is more memory efficient in this implementation, this is because the ```ToString()``` method is only called once. If a ```string``` was used instead of a ```StringBuilder``` by using ```string output += "Pling"``` then this would have created a new object on the heap each time the ```string``` value changed.







## Tests

``` c#
public void TestName(int input, string expected)
{
	string actual = obj.PlingPlangPlong(input);
	Assert.That(actual, Is.EqualTo(expected));
}
```

All Unit Tests were written in this format with three or four ```TestCase[]```'s each. The ```TestCase[]``` would specify the input and expected output as shown in the method above.

The tests were:

1. A number that is divisible by three returns "Pling".
2. A number that is divisible by five returns "Plang".
3. A number that is divisible by seven returns "Plong".
4. A number that is not divisible by three, five or seven returns the input number.
5. A number that is divisible by both three and five returns "PlingPlang".
6. A number that is divisible by both three and seven returns "PlingPlong".
7. A number that is divisible by both five and seven returns "PlangPlong".
8. A number that is divisible by three, five and seven returns "PlingPlangPlong".



Tests 1 to 3 had four ```TestCase[]```'s and tests 4 to 8 had three ```TestCase[]```'s. Each test had a negative number test to ensure that the correct output would still be given even with a negative number for input.

