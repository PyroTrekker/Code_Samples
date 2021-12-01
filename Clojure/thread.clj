(println "Starting another thread...")

;; Used Thread/sleep to simulate long running process
(def what-is-the-answer-to-life (future 
        (Thread/sleep 3000) ;; running for 3 seconds
        (dotimes [i 10] (println "Thread line " (+ i 1)))))
(Thread/sleep 10000) ;; Wait 10 seconds for the thread
(println "Thread execution finished.")
(println "Goodbye!")
(shutdown-agents)