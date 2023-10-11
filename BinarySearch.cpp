#include <iostream>
using namespace std;

int binarySearch(int arr[], int target, int left, int right) {
    if (left <= right) {
        int mid = left + (right - left) / 2;
        if (arr[mid] == target) {
            return mid; 
        } else if (arr[mid] < target) {
            return binarySearch(arr, target, mid + 1, right); 
        } else {
            return binarySearch(arr, target, left, mid - 1); 
        }
    }
    return -1; 
}

int main() {
    int arr[] = {1, 3, 5, 7, 9, 11, 13, 15, 17, 19};
    int size = sizeof(arr) / sizeof(arr[0]);
    int target;
    cout << "Enter the element to be searched: ";
    cin >> target;
    int result = binarySearch(arr, target, 0, size - 1);
    if (result != -1) {
        cout << "Element found at index: " << result << endl;
    } else {
        cout << "Element not found in the array." << endl;
    }

    return 0;
}
