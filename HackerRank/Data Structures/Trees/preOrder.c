#include <stdio.h>
#include <stdlib.h>

struct node {
    int data;
    struct node *left;
    struct node *right;
};

struct node *removeElement(struct node* arr[], int length, int index) {
    struct node* popped;
    for (int i = index; i < length; i++) {
        popped = arr[i];
        arr[i] = arr[i+1]; 
    }
    return popped;
}

void preOrder(struct node *root) {
    struct node* stack[200] = {root};
    int length = 1;
    while (length > 0) {
        struct node* popped = removeElement(stack, length, length - 1);
        printf("%d ", popped->data);
        length--;
        if (popped->right) {
            length+=1;
            stack[length - 1] = popped->right;
        }
        if (popped->left) {
            length+=1;
            stack[length - 1] = popped->left;
        }
    }
}
