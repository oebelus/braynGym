int count(SinglyLinkedListNode *head) {
    int count = 0;
    while (head != NULL) {
        count++;
        head = head->next;
    }
    return count;
}

SinglyLinkedListNode* getNode(SinglyLinkedListNode *head, int difference) {
    int count = 0;
    while (count < difference) {
        head = head->next;
        count++;
    }
    return head;
}

int findMergeNode(SinglyLinkedListNode* head1, SinglyLinkedListNode* head2) {
    SinglyLinkedListNode* current1 = head1;
    SinglyLinkedListNode* current2 = head2;
    
    int len1 = count(head1);
    int len2 = count(head2);
    int difference = 0;
    
    int answer = 0;
    
    if (len1 > len2) {
        difference = len1-len2;
        current1 = getNode(current1, difference);
    }
    if (len2 > len1) {
        difference = len2 - len1;
        current2 = getNode(current2, difference);
    }
    
    while (current1 != NULL && current2 != NULL) {
        if (current1 == current2) return current1->data;
        current1 = current1->next;
        current2 = current2->next;
    }
    return -1;

}
