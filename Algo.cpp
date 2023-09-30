#include <iostream> //Sum of n numbers of an array
using namespace std;
int main(){
    int arr[10];
    int n, sum=0, count=0, i;
    count=count+1;
    cout<<"Enter the value: ";
    cin>>n;
    count=count+1;
    cout << "Enter " << n << " numbers: ";
    for(i=0;i<n;i++){
        count=count+1;
        cin>>arr[i];       
    }
    count=count+1;
    for(i=0;i<n;i++){
        count=count+1;
        sum+=arr[i];
        count=count+1;
    }
    count=count+1;
    cout<<"the sum is: "<<sum<<endl;
    cout<<"the count is: "<<count;
    return 0;
}