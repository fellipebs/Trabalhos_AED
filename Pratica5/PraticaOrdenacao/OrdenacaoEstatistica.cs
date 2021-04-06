namespace Pratica5 {
    class OrdenacaoEstatistica {
        // TODO: contador de comparações e trocas
        // TODO: declarar demais métodos de ordenação
        public static int cont_c, cont_t;
        public static int[] Bolha(int[] vet) {
            int cont_cc = 0;
            int cont_tt = 0;
            int[] vetAux = new int[2];
            int i, j, temp;
            for (i = 0; i < vet.Length - 1; i++) {
                for (j = vet.Length - 1; j > i; j--) {
                    cont_cc++;
                    if (vet[j] < vet[j - 1]) {
                        temp = vet[j];    
                        vet[j] = vet[j - 1];
                        vet[j - 1] = temp;
                        cont_tt++;
                    }
                }
            }
            vetAux[0] = cont_cc;
            vetAux[1] = cont_tt;
            return vetAux;
        }

        public static int[] selecao(int[] vet)
        {
            int cont_cc = 0;
            int cont_tt = 0;
            int[] vetAux = new int[2];
            int i, j, min, temp;
            for (i = 0; i < vet.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < vet.Length; j++)
                {
                    cont_cc++;
                    if (vet[j] < vet[min])
                    {
                        min = j;
                    }
                }
                temp = vet[i];
                vet[i] = vet[min];
                vet[min] = temp;
                cont_tt++;
            }
            vetAux[0] = cont_cc;
            vetAux[1] = cont_tt;
            return vetAux;
        }

        public static int[] insercao(int[] vet)
        {
            int temp, i, j;
            int cont_cc = 0;
            int cont_tt = 0;
            int[] vetAux = new int[2];
            for (i = 1; i < vet.Length; i++)
            {
                temp = vet[i];
                j = i - 1;
                cont_cc++;
                while (j >= 0 && temp < vet[j])
                {
                    vet[j + 1] = vet[j];
                    j--;
                    cont_tt++;
                }
                vet[j + 1] = temp;
            }
            vetAux[0] = cont_cc;
            vetAux[1] = cont_tt;
            return vetAux;
        }

        public static int[] shellSort(int[] vet)
        {
            int i, j, x, n;
            int h = 1;
            int cont_cc = 0;
            int cont_tt = 0;
            int[] vetAux = new int[2];
            n = vet.Length;
            do
            {
                h = h * 3 + 1;
            } while (h <= n);
            do
            {
                h /= 3;
                for (i = h; i < n; i++)
                {
                    x = vet[i];
                    j = i;
                    cont_cc++;
                    while (j > (h - 1) && vet[j - h] > x)
                    {
                        vet[j] = vet[j - h];
                        j -= h;
                        cont_tt++;
                    }
                    vet[j] = x;
                }
            } while (h != 1);
            vetAux[0] = cont_cc;
            vetAux[1] = cont_tt;
            return vetAux;
        }

        public static int cont_cc_quick = 0;
        public static int cont_tt_quick = 0;
        public static int[] quickSortAux(int[] vet, int esq, int dir)
        {
            int[] ve2 = vet;
            int esq2 = esq;
            int dir2 = dir;

            cont_cc_quick = 0;
            cont_tt_quick = 0;
            int[] vetAux = new int[2];

            quickSort(ve2, esq2, dir2);

            vetAux[0] = cont_cc_quick;
            vetAux[1] = cont_tt_quick;
            return vetAux;
        }
        public static void quickSort(int[] vet, int esq, int dir)
        {
            int i, j, x, temp;

            x = vet[(esq + dir) / 2]; // pivo
            i = esq;
            j = dir;
            do
            {
                while (x > vet[i]) i++;
                while (x < vet[j]) j--;
                cont_cc_quick += 2;
                if (i <= j)
                {
                    temp = vet[i];
                    vet[i] = vet[j];
                    vet[j] = temp;
                    cont_tt_quick++;
                    i++;
                    j--;
                }
                cont_cc_quick++;
            } while (i <= j);
            cont_cc_quick++;
            if (esq < j) quickSort(vet, esq, j);
            cont_cc_quick++;
            if (i < dir) quickSort(vet, i, dir);
        }

        public static int cont_cc_heap = 0;
        public static int cont_tt_heap = 0;
        public static int[] heapsortAux(int[] vet)
        {
            int[] ve2 = vet;
            cont_cc_heap = 0;
            cont_tt_heap = 0;
            int[] vetAux = new int[2];

            heapSort(ve2);

            vetAux[0] = cont_cc_heap;
            vetAux[1] = cont_tt_heap;
            return vetAux;
        }



        public static void heapSort(int[] v)
        {
            constroiMaxHeap(v);
            int n = v.Length;

            for (int i = v.Length - 1; i > 0; i--)
            {
                cont_cc_heap++;
                troca(v, i, 0);
                refaz(v, 0, --n);
            }
        }

        private static void constroiMaxHeap(int[] v)
        {
            for (int i = v.Length / 2 - 1; i >= 0; i--) {
                cont_cc_heap++;
                refaz(v, i, v.Length);
            }
        }

        private static void refaz(int[] vetor, int pos, int tamanhoDoVetor)
        {

            int max = 2 * pos + 1, right = max + 1;
            cont_cc_heap++;
            if (max < tamanhoDoVetor)
            {
                cont_cc_heap++;
                if (right < tamanhoDoVetor && vetor[max] < vetor[right])
                    max = right;
                cont_cc_heap++;
                if (vetor[max] > vetor[pos])
                {
                    troca(vetor, max, pos);
                    refaz(vetor, max, tamanhoDoVetor);
                }
            }
        }

        public static void troca(int[] v, int j, int aposJ)
        {
            int aux = v[j];
            v[j] = v[aposJ];
            v[aposJ] = aux;
            cont_tt_heap++;
        }


        public static int cont_cc_merge = 0;
        public static int cont_tt_merge = 0;
        public static int[] mergeSortAux(int[] v, int i, int j)
        {
            int[] ve2 = v;
            int i2 = i;
            int j2 = j;
            cont_cc_merge = 0;
            cont_tt_merge = 0;
            int[] vetAux = new int[2];

            mergeSort(ve2, i2, j2);

            vetAux[0] = cont_cc_merge;
            vetAux[1] = cont_tt_merge;
            return vetAux;
        }

        private static void merge(int[] v, int i, int m, int j)
        {
            int[] temp = new int[m - i + 1];
            int k;
            for (k = i; k <= m; k++)
            {
                temp[k - i] = v[k];
                cont_tt_merge++;
            }
            int esq = 0, dir = m + 1;
            k = m - i + 1;
            while (esq < k && dir <= j)
            {
                cont_cc_merge++;
                if (temp[esq] <= v[dir])
                    v[i++] = temp[esq++];
                else
                    v[i++] = v[dir++];

                cont_tt_merge++;
            }
            while (esq < k)
            {
                v[i++] = temp[esq++];
                cont_cc_merge++;
            }
        }

        public static void mergeSort(int[] v, int i, int j)
        {
            cont_cc_merge++;
            if (i < j)
            {
                int m = (i + j) / 2;
                mergeSort(v, i, m);
                mergeSort(v, m + 1, j);
                merge(v, i, m, j); // intercala v[i..m] e v[m+1..j] em v[i..j] 
            }
        }
    }
}
