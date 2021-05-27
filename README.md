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
	bool isAFactor = false;

	if (input % 3 == 0){
		sb.Append("Pling");
		isAFactor = true;
	}

	if (input % 5 == 0){
		sb.Append("Plang");
		isAFactor = true;
	}

	if (input % 7 == 0){
		sb.Append("Plong");
		isAFactor = true;
	}

	return (isAFactor == true) ? sb.ToString() : input.ToString();
}
```

This method checks if an input intager is divisable by 3, 5 or 7. If any conditions are met the corosponding string is returned, in contrast if the input is not divisable by 3, 5 or 7 then the input number is returned.



I chose to use a ```StringBuilder``` instead of a ```string``` because it is more memory efficient in this implementation, this is because the ```ToString()``` method is only called once. If a ```string``` was used instead of a ```StringBuilder``` by using ```string output += "Pling"``` then this would have created a new object on the heap each time the ```string``` value chaned.







## Tests











