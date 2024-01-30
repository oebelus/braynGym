DoublyLinkedListNode* sortedInsert(DoublyLinkedListNode* llist, int data) {
        struct DoublyLinkedListNode* node = (struct DoublyLinkedListNode*)malloc(sizeof(struct DoublyLinkedListNode*));
        node->data = data;
        node->next = NULL;
        struct DoublyLinkedListNode* linked = (struct DoublyLinkedListNode*)malloc(sizeof(struct DoublyLinkedListNode*));
        linked->data = 0;
        linked->next = NULL;
        struct DoublyLinkedListNode* tail = linked;
        while (llist->next != NULL) {
            if (llist->data < data) {
                tail->next = llist;
                tail = tail->next;
            }
            else break;
            llist = llist->next;
        }
        if (llist->data < node->data) {
            tail->next = llist;
            llist->next = node;
        }
        else {
            tail->next = node;
            node->next = llist;
        }
        return linked->next;
}
