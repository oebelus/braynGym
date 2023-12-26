void printLinkedList(SinglyLinkedListNode* head) {
    SinglyLinkedListNode* current = head;
    while (current) {
        printf("%d\n", current->data);
        current = current->next;
    }
}
