using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.IO.IsolatedStorage;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double max = double.MinValue;
            double sum = 0;
            double avg = 0;
            int target = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (max < array[i])
                {
                    max = Math.Max(max, array[i]);
                    target = i;
                }
                
                
            }

            avg = sum / array.Length;

            for (int i = array.Length-1; i > target; i--)
            {
                array[i] = avg;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            
            even = new int[(array.Length + 1) / 2];
            odd = new int[array.Length / 2];

            for(int i = 0, j = 0, h = 0; i < array.Length; i ++)
            {
                if(i % 2 == 0)
                {
                    even[j] = array[i];
                    j++;
                }
                else
                {
                    odd[h] = array[i];
                    h++;
                }
            }

            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here

            answer = new int[array.Length + 1];
            double avg = 0;
            int sum = 0;
            int target = 0;
            double minDelta = double.MaxValue;

            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            avg = (double)sum / array.Length;

            for(int i = 0; i < array.Length; i++)
            {
                if (minDelta > Math.Abs(avg - array[i]))
                {
                    target = i;
                    minDelta = Math.Abs(avg - array[i]);
                }
            }

            for(int i = 0, j = 0; i < array.Length; i++, j++)
            {
                answer[j] = array[i];
                if (i == target)
                {
                    j++;
                    answer[j] = P;
                }
            }


            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] tempArr = new int[array.Length];

            for(int readLeft = 0, writeLeft = 0, readRight = array.Length-1, writeRight = array.Length-1; readLeft < array.Length; readLeft++, readRight--)
            {
                if (array[readLeft] >= 0)
                {
                    tempArr[writeLeft] = array[readLeft];
                    writeLeft++;
                }
                if (array[readRight] < 0)
                {
                    tempArr[writeRight] = array[readRight];
                    writeRight--;
                }
            }

            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = tempArr[i];
            }
            
            
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];

            if (k > A.Length) k = A.Length;

            for(int i = 0, a = 0, b = 0; i < answer.Length; i++)
            {
                if (i > k - 1 && b < B.Length)
                {
                    answer[i] = B[b];
                    b++;
                }
                else
                {
                    answer[i] = A[a];
                    a++;
                }
            }

            // напомнить об ошибке хз.
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length != B.Length) return (sum, dif);

            sum = new int[A.Length];
            dif = new int[A.Length];

            for(int i = 0, j = 0; i < sum.Length; i++)
            {
                sum[i] = A[i] + B[i];
            }

            for (int i = 0, j = 0; i < dif.Length; i++)
            {
                dif[i] = A[i] - B[i];
            }


            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here

            
            int max = int.MinValue;
            int min = int.MaxValue;
            int check = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
                min = Math.Min(min, array[i]);
            }

            if (min - max == 0) return normalized;

            normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (2 * ((array[i] - min)/(double)(max - min)) - 1);
            }

            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];

            int i = 1, n = A.Length;

            while (i < n)
            {
                if (i == 0 || A[i] <= A[i - 1])
                    i++;
                else
                {
                    (A[i], A[i - 1]) = (A[i - 1], A[i]);
                    i--;
                }

            }

            i = 1;
            n = B.Length;

            while (i < n)
            {
                if (i == 0 || B[i] <= B[i - 1])
                    i++;
                else
                {
                    (B[i], B[i - 1]) = (B[i - 1], B[i]);
                    i--;
                }

            }

            i = 0;
            int j = 0, k = 0;

            while (i < A.Length && j < B.Length)
            {
                if (A[i] >= B[j])
                    C[k++] = A[i++];
                else
                    C[k++] = B[j++];
                
            }

            while (i < A.Length)
            {
                C[k++] = A[i++];
            }

            while (j < B.Length)
            {
                C[k++] = B[j++];
            }

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here

            // end

            return (bright, normal, dim);
        }
    }
 }
