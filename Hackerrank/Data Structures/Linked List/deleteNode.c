SinglyLinkedListNode* deleteNode(SinglyLinkedListNode* llist, int position) {
     if (position == 0) {
        SinglyLinkedListNode* tmp = llist->next;
        llist = llist->next;
    }
    else {
        SinglyLinkedListNode* current = llist;
        int count = 1;
        while (llist->next != NULL && count < position) {
            current = current->next;
            count++;
        }
        SinglyLinkedListNode* tmp = current->next;
        current->next = tmp->next;
    }
    return llist;
}
