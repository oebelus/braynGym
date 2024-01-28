bool compare_lists(SinglyLinkedListNode* head1, SinglyLinkedListNode* head2) {
    SinglyLinkedListNode* current1 = head1;
    SinglyLinkedListNode* current2 = head2;
    
    while (current1->next != NULL) {
        if (current2->next == NULL) return false;
        else {
            if (current1->data != current2->data) return false;
            current1 = current1->next;
            current2 = current2->next;
        }
    } 
    return true;
}
