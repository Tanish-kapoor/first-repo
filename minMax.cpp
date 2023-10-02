#include <iostream>
using namespace std;

void DAC_max_min(int arr[], int i, int j, int& max, int& min) {
    if (i == j) {
        max = min = arr[i];
    } else if (i == j - 1) {
        if (arr[i] < arr[j]) {
            max = arr[j];
            min = arr[i];
        } else {
            max = arr[i];
            min = arr[j];
        }
    } else {
        int mid = (i + j) / 2;
        int max1, min1, max2, min2;
        DAC_max_min(arr, i, mid, max1, min1);
        DAC_max_min(arr, mid + 1, j, max2, min2);

        //max = (max1 < max2) ? max2 : max1;
        //min = (min1 < min2) ? min1 : min2;
         if(max1<max2)
            max=max2;
        else
            max=max1;
        if(min1<min2)
            min=min1;
        else
            min=min2;
    }
}

int main() {
    int arr[] = {3, 7, 0, 9, 5, 2, 8, 90};
    int i = 0;
    int j = (sizeof(arr) / sizeof(arr[0])) - 1;
    int max = 0;
    int min = 0;

    DAC_max_min(arr, i, j, max, min);

    cout << "Maximum element: " << max << endl;
    cout << "Minimum element: " << min << endl;

    return 0;
}
