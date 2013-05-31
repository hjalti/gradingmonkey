var grades = /*grades*/;

for (var kt in grades)
{
	console.log('Setting grade: '+kt)
	var select = document.getElementById("g"+kt);
    var found = false;
	for(j = 0; j != select.options.length; j++)
	{
		if(select.options[j].value == grades[kt])
		{
			select.options[j].selected = true;
            found = true;
			break;
		}
	}
    if(!found)
    {
        throw 'Could not select grade for ' + kt + '. The grade ' + grades[kt] + ' is not an option.'
    }
}