SinglyLinkedListNode* insertNodeAtPosition(SinglyLinkedListNode* llist, int data, int position) {
    SinglyLinkedListNode* node = (SinglyLinkedListNode*)malloc(sizeof(SinglyLinkedListNode));
    node->data = data;
    node->next = NULL; 
    if (position == 0) {
        node->next = llist;
    } else {
        int count = 1;
        SinglyLinkedListNode* current = llist; 
        while (llist->next != NULL && count < position) {
            current = current->next;
            count++;
        }
        SinglyLinkedListNode* tmp = current->next; 
        current->next = node; 
        node->next = tmp;
    }
    return llist;
}
