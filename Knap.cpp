#include <iostream>
using namespace std;
struct Item {
    int weight;
    int profit;
    double ratio;

    Item(int w, int p) : weight(w), profit(p), ratio(static_cast<double>(p) / w) {}
};

bool compareItems(const Item& a, const Item& b) {
    return a.ratio > b.ratio;
}

void bubbleSort(Item* items, int n) {
    for (int i = 0; i < n - 1; ++i) {
        for (int j = 0; j < n - i - 1; ++j) {
            if (items[j].ratio < items[j + 1].ratio) {
                swap(items[j], items[j + 1]);
            }
        }
    }
}

double fractionalKnapsack(int capacity, Item* items, int n) {
    bubbleSort(items, n);

    double totalProfit = 0.0;

    for (int i = 0; i < n; ++i) {
        if (capacity >= items[i].weight) {
            totalProfit += items[i].profit;
            capacity -= items[i].weight;
        } else {
            totalProfit += items[i].ratio * capacity;
            break;
        }
    }

    return totalProfit;
}

int main() {
    int n; // Number of items
    cout << "Enter the number of items: ";
    cin >> n;

    Item* items = new Item[n];

    cout << "Enter weights and profits of items:" << endl;
    for (int i = 0; i < n; ++i) {
        int weight, profit;
        cin >> weight >> profit;
        items[i] = Item(weight, profit);
    }

    int capacity;
    cout << "Enter the knapsack capacity: ";
    cin >> capacity;

    double maxProfit = fractionalKnapsack(capacity, items, n);
    cout << "Maximum profit that can be obtained: " << maxProfit << endl;

    delete[] items; 
    return 0;
}
+2