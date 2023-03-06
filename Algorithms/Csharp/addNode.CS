public void addNode(MultiListNode node, int nodeValue, bool isChild) {
    MultiListNode current = new MultiListNode();
    current.val = nodeValue;
    if(isChild) {
        node.child = current;
    } else {
        node.next = current;
    }

}

