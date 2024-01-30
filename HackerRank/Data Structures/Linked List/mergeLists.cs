static SinglyLinkedListNode MergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        SinglyLinkedListNode linked = new(0);
        SinglyLinkedListNode tail = linked;
        
        while (head1 != null && head2 != null) {
            if (head1.data < head2.data) {
                tail.next = head1;
                head1 = head1.next;
            } else {
                tail.next = head2;
                head2 = head2.next;
            }
            tail = tail.next;
        }
        
        if (head1 != null) tail.next = head1;
        if (head2 != null) tail.next = head2;
        tail = linked;
        return tail.next;
    }
