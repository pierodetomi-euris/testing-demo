Data una stringa in input, generare un codice composto così:

```PREFIX + BODY + SUFFIX```

## Generazione PREFIX
- Se la prima lettera è una _vocale_ => ```PREFIX = "VC"```
- Se la prima lettera NON è una _vocale_ => ```PREFIX = "OT"```

## Generazione BODY
Il body sarà determinato dalla concatenazione di:

- ```"B"```
- Lunghezza della stringa di input
- Data la terza lettera dell'input:
  - Se è una _vocale_ => ```"00--"```
  - Se NON è una _vocale_ => ```"000:"```

## Generazione SUFFIX
- Se la lunghezza della stringa di input è _pari_ => ```"$PR"```
- Se la lunghezza della stringa di input è _dispari_ => ```"$DS"```