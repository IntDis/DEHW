using HW_AIO;
Console.WriteLine();
//int total;
//int rest;
//Variables.GetADividedByB(11, 2, out total, out rest);                                                               //1.1
//Console.WriteLine($"A/B = {total}, A%B = {rest}");

//Console.WriteLine(Variables.GetSolutionOfQuadraticEquation(6, 3));                            //1.2

//string a = "string";
//string b = "12345678";
//Variables.SwapAtoB(ref a, ref b);                                                             //1.3 
//Console.WriteLine($"a = {a}, b = {b}");

//int a = 5;
//int b = 25;
//Console.WriteLine($"a = {a}, b = {b}");
//Variables.SwapAToBInts(ref a, ref b);                             //int swap method proof
//Console.WriteLine($"a = {a}, b = {b}");

//Console.WriteLine(Variables.GetSolutionOfLinearEquation(3, 5, 11));                           //1.4

//Console.WriteLine(Variables.GetLinearEquation(1, 1, 3, 4));                                   //1.5


///*_____________________________________________________________________________________________*/

//Console.WriteLine(Branches.GetSumOfAAndB(3, 2));                                              //2.1

//Console.WriteLine(Branches.GetQuarterOfPoint(7.25, -3));                                      //2.2

//Console.WriteLine(Branches.GetNumbersInAscendingOrder(111, 0, -232.5));                       //2.3

//Branches.GetSolutionOfQuadraticEquation(1, 0, -49);                                           //2.4

//Console.WriteLine(Branches.GetNumberInWords(-29));                                            //2.5


///*_____________________________________________________________________________________________*/
//Console.WriteLine(Cycles.GetAInDegreeOfB(3, 2));                                              //3.1

//ArrayMethods.PrintArrayElements(Cycles.GetNumbersIfDivisionByAIsZero(333));                   //3.2

//Console.WriteLine(Cycles.GetCountOfNumbersIfTheirSquareIsLowerThanA(88));                     //3.3

//Console.WriteLine(Cycles.GetMaxDividerOfA(135));                                              //3.4

//Console.WriteLine(Cycles.GetSumOfNumbersFromAToBWhichDivisionBySevenIsZero(100, 4));          //3.5

//Console.WriteLine(Cycles.GetPositonValueFromFibonacci(7));                                    //3.6

//Console.WriteLine(Cycles.GetMaxDividerOfTwoNumbersByEuclid(-48, 32));                         //3.7

//Console.WriteLine(Cycles.GetThirdRootFromNumberByHalfDivision(512));                          //3.8

//Console.WriteLine(Cycles.GetCountOfEvenDigitsInNumber(3236));                                 //3.9

//Console.WriteLine(Cycles.GetReversedNumber(1234));                                            //3.10

//Cycles.WriteNumbersIfEvenDigitsSumBiggerThanOdd(1234);                                        //3.11

//Console.WriteLine(Cycles.AreNumbersHavingSameDigits(-1000, 1024));                            //3.12


///*_____________________________________________________________________________________________*/

//ArrayMethods.PrintArray(ArrayMethods.GenerateRandomArray(10));

int[] arr = ArrayMethods.GenerateRandomArray(5);
ArrayMethods.PrintArray(arr);
Console.WriteLine(ArrayMethods.GetMinElement(arr));                                           //4.1

Console.WriteLine(ArrayMethods.GetMaxElement(arr));                                           //4.2

Console.WriteLine(ArrayMethods.GetMinElementIndex(arr));                                      //4.3

Console.WriteLine(ArrayMethods.GetMaxElementIndex(arr));                                      //4.4

Console.WriteLine(ArrayMethods.GetSumOfEvenNumbers(arr));                                     //4.5