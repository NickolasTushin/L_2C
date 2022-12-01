Console.Clear();
int Max(int arg1, int arg2, int arg3)
{
int result = arg1;
if (arg2> result) result = arg2;
if (arg3> result) result = arg3;
return result;
}
int a1 = 12225;
int b1 = 9000;
int c1 = 39;
int a2 = 189772;
int b2 = 2311;
int c2 = 3833;
int a3 = 133434;
int b3 = 2300;
int c3 = 313;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
int max = Max(
Max(a1,b1,c1),
Max(a2,b2,c2),
Max(a3,b3,c3));
Console.WriteLine(max);