SinglyLinkedListNode* removeDuplicates(SinglyLinkedListNode* llist) {
    SinglyLinkedListNode* current = llist;
    SinglyLinkedListNode* nextNode = current->next;
    while (current != NULL && current->next != NULL) {
        while (current->next != NULL && current->data == nextNode->data) {
            nextNode = nextNode->next;
            current->next = nextNode;
        }
        current = current->next;
        nextNode = nextNode->next;
    }
    return llist; 
}
