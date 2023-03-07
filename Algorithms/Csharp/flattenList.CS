public static MultiListNode flatten(MultiListNode head) { //turns a multi-level linked list into a normal linked list
    const start = head; //                  then returns its head

    while(head != null) {
        if(head.child != null) {
            branch = head.child;
            while(branch.next != null) {
                branch = branch.next;
            }
            branch.next = head.next;
            head.next = child;
            head.child = null;
        }
        head = head.next;
    }
    return start;
}