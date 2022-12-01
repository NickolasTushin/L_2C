void Fillarray(int [] collection)
    {
int length = collection. Length;
int index = 0;
while (index < length)
{
    collection [index] = new Random() .Next (1, 10);

    //index = index + 1;
    index ++;
}
    }


void Printarray(int [] col)
{
int count = col. Length;
int position1 = 0;

while (position1 < count)
{Console.WriteLine(col[position1]);

position1 ++;
}
}



int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position= -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        
        index ++;
    }
    return position;
}



int [] array = new int [10];

Fillarray (array);
Printarray (array);
Console.WriteLine();
int pos = Index0f(array, 994);
Console. WriteLine (pos);



