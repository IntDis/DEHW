using HW_AIO;
Console.WriteLine();

//int total;
//int rest;
//Variables.GetADividedByB(11, 2, out total, out rest);
//Console.WriteLine($"A/B = {total}, A%B = {rest}");                                            //1.1

//Console.WriteLine(Variables.GetSolutionOfQuadraticEquation(6, 3));                            //1.2

//string a = "string";
//string b = "12345678";
//Console.WriteLine($"a = {a}, b = {b}");
//Variables.SwapAToB(ref a, ref b);                             //string swap method
//Console.WriteLine($"a = {a}, b = {b}");

//int f = 5;
//int m = 25;
//Console.WriteLine($"f = {f}, m = {m}");
//Variables.SwapAToB(ref f, ref m);                             //int swap method
//Console.WriteLine($"f = {f}, m = {m}");                                                       //1.3 

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

//ArrayMethods.PrintArray(Cycles.GetNumbersIfDivisionByAIsZero(333));                           //3.2

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


int[] arr = ArrayMethods.GenerateRandomArray(5);
ArrayMethods.PrintArray(arr);
//ArrayMethods.SwapAToB(ref arr, 0, arr.Length - 1);
//ArrayMethods.PrintArray(arr);

//Console.WriteLine(ArrayMethods.GetMinElement(arr));                                           //4.1

//Console.WriteLine(ArrayMethods.GetMaxElement(arr));                                           //4.2

//Console.WriteLine(ArrayMethods.GetMinElementIndex(arr));                                      //4.3

//Console.WriteLine(ArrayMethods.GetMaxElementIndex(arr));                                      //4.4

//Console.WriteLine(ArrayMethods.GetSumOfEvenIndexNumbers(arr));                                //4.5

//ArrayMethods.ReverseArray(ref arr);                                                           //4.6
//ArrayMethods.PrintArray(arr);

//Console.WriteLine(ArrayMethods.GetAmountOfOddElements(arr));                                  //4.7

//ArrayMethods.ReverseHalfOfArray(ref arr);                                                     //4.8
//ArrayMethods.PrintArray(arr);

//ArrayMethods.SortArrayInAscendingOrderByInjection(ref arr);                                   //4.9

//ArrayMethods.SortArrayInDescendingOrderBySelection(ref arr);                                  //4.10
//ArrayMethods.PrintArray(arr);