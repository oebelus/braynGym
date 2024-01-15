SinglyLinkedListNode* insertNodeAtTail(SinglyLinkedListNode* head, int data) {
    SinglyLinkedListNode* node = (SinglyLinkedListNode*)malloc(sizeof(SinglyLinkedListNode));
    node->data = data;
    node->next = NULL;
    if (head == NULL) {
        head = node;
    }
    else {
        SinglyLinkedListNode* current = head;
        while (current->next != NULL) {
            current = current->next;
        }
        current->next = node;
    }
    return head; 
}
