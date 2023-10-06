#include <iostream>
using namespace std;

void merge(int array[], int lb, int mid, int ub) {
    int i = lb;
    int j = mid + 1;
    int k = 0; // Index for the temporary array
    int temp[ub - lb + 1]; // Size of temp array is (ub - lb + 1)

    while (i <= mid && j <= ub) {
        if (array[i] <= array[j]) {
            temp[k] = array[i];
            i++;
        } else {
            temp[k] = array[j];
            j++;
        }
        k++;
    }

    while (i <= mid) {
        temp[k] = array[i];
        i++;
        k++;
    }

    while (j <= ub) {
        temp[k] = array[j];
        j++;
        k++;
    }

    // Copy elements from temp back to the original array
    for (k = 0; k <= (ub - lb); k++) {
        array[lb + k] = temp[k];
    }
}


void mergeSort(int array[], int lb, int ub) {
    if (lb < ub) {
        int mid = (lb + ub) / 2;
        mergeSort(array, lb, mid);
        mergeSort(array, mid + 1, ub);
        merge(array, lb, mid, ub);
    }
}

int main() {
    int array[] = {12, 11, 13, 5, 6, 7};
    int size = sizeof(array) / sizeof(array[0]);

    cout << "Original array: ";
    for (int i = 0; i < size; i++) {
        cout << array[i] << " ";
    }
    cout << endl;

    mergeSort(array, 0, size - 1);

    cout << "Sorted array: ";
    for (int i = 0; i < size; i++) {
        cout << array[i] << " ";
    }
    cout << endl;

    return 0;
}
