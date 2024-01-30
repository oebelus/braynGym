SinglyLinkedListNode* mergeLists(SinglyLinkedListNode* head1, SinglyLinkedListNode* head2) {
    SinglyLinkedListNode* linked = (struct SinglyLinkedListNode*)malloc(sizeof(struct SinglyLinkedListNode));
    SinglyLinkedListNode* current = linked; // Points to the last node of Linked
    linked->data = 0;
    linked->next = NULL;
    
    while (head1 && head2) {
        SinglyLinkedListNode* add = (struct SinglyLinkedListNode*)malloc(sizeof(struct SinglyLinkedListNode));
        add->data = 0;
        add->next = NULL;
        if (head1->data <= head2->data) {
            add->data = head1->data;
            current->next = add;
            current = current->next;
            head1 = head1->next;
        } else if (head1->data >= head2->data) {
            add->data = head2->data;
            current->next = add;
            current = current->next;
            head2 = head2->next;
        }
    }
    while (head1) {
        SinglyLinkedListNode* add = (struct SinglyLinkedListNode*)malloc(sizeof(struct SinglyLinkedListNode));
        add->data = 0;
        add->next = NULL;
        add->data = head1->data;
        current->next = add;
        current = current->next;
        head1 = head1->next;
    }
    
    while (head2) {
        SinglyLinkedListNode* add = (struct SinglyLinkedListNode*)malloc(sizeof(struct SinglyLinkedListNode));
        add->data = 0;
        add->next = NULL;
        add->data = head2->data;
        current->next = add;
        current = current->next;
        head2 = head2->next;
    }
    return linked->next;
}
