int getNode(SinglyLinkedListNode* llist, int positionFromTail) {
    SinglyLinkedListNode* head = llist;
    SinglyLinkedListNode* prev = NULL;
    while (head != NULL) {
        SinglyLinkedListNode *nextNode = head->next;
        head->next = prev;
        prev = head;
        head = nextNode;
    }
    head = prev;
    SinglyLinkedListNode* current = head;
    int count = 0;
    while (count < positionFromTail && current->next != NULL) {
        current = current->next;
        count++;
    }
    return current->data;
}
