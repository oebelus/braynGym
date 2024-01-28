void reversePrint(SinglyLinkedListNode* llist) {
    SinglyLinkedListNode* head = llist;
    SinglyLinkedListNode* prev = NULL;
    while (head != NULL) {
        SinglyLinkedListNode* nextNode = head->next;
        head->next = prev;
        prev = head; 
        head = nextNode;
    }
    head = prev;
    SinglyLinkedListNode* current = head; 
    while (current->next != NULL) {
        printf("%d\n", current->data);
        current = current->next; 
    }
    printf("%d\n", current->data);
}
