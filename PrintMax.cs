﻿namespace TestMaximum
{
    public class PrintMax<T> where T : IComparable
    {
        public T A, B, C, Max;
        public PrintMax(T A, T B, T C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public static T MaxNum(T A, T B, T C)
        {
            if (A.CompareTo(B) > 0 && A.CompareTo(C) > 0 ||
                    A.CompareTo(B) >= 0 && A.CompareTo(C) > 0 ||
                    A.CompareTo(B) > 0 && A.CompareTo(C) >= 0)
            {
                return A;
            }

            if (B.CompareTo(A) > 0 && B.CompareTo(C) > 0 ||
                    B.CompareTo(A) >= 0 && B.CompareTo(C) > 0 ||
                    B.CompareTo(B) > 0 && B.CompareTo(C) >= 0)
            {
                return B;
            }

            if (C.CompareTo(B) > 0 && C.CompareTo(A) > 0 ||
                    C.CompareTo(B) >= 0 && C.CompareTo(A) > 0 ||
                    C.CompareTo(B) > 0 && C.CompareTo(A) >= 0)
            {
                return C;
            }
            return default;
        }
        public T MaxMethod()
        {
            Max = PrintMax<T>.MaxNum(this.A, this.B, this.C);
            toPrint(Max);
            return Max;

        }
        public void toPrint(T Max)
        {
            Console.WriteLine("Maximum is " + Max);
        }
    }
}
